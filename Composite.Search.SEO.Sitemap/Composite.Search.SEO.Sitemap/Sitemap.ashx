﻿	<%@ WebHandler Language="C#" Class="Sitemap" %>
	/* version for 1.3 */
using System;
using System.Globalization;
using System.Text;
using System.Web;
using Composite.Data;
using Composite.Data.Types;
using Composite.WebClient;

public class Sitemap : IHttpHandler
{
	protected string Changefreq = "monthly";

	public void ProcessRequest(HttpContext context)
	{
		context.Response.ContentType = "text/xml";

		var xml = new StringBuilder();
		xml.Append("<?xml version=\"1.0\" encoding=\"UTF-8\"?>");
		xml.Append("<urlset xmlns=\"http://www.sitemaps.org/schemas/sitemap/0.9\">");

		var cultures = DataLocalizationFacade.IsLocalized(typeof(IPage)) ? DataLocalizationFacade.ActiveLocalizationCultures : new[] { CultureInfo.InvariantCulture };

		foreach (var cultureInfo in cultures)
		{
			using (new DataScope(cultureInfo))
			{
				var pages = DataFacade.GetData<IPage>();
				foreach (var page in pages)
				{
					var url = PageUrlHelper.BuildUrl(UrlType.Public, new PageUrlOptions(DataScopeIdentifier.PublicName, cultureInfo, page.Id));

					if(url != null)
					{
						var pageUrl = GetFullPath(url.ToString());
						xml.Append("<url>");
						xml.AppendFormat("<loc>{0}</loc>", pageUrl);
						xml.AppendFormat("<lastmod>{0}</lastmod>", page.ChangeDate.ToString("yyyy-MM-dd"));
						xml.AppendFormat("<changefreq>{0}</changefreq>", Changefreq);
						xml.AppendFormat("<priority>{0}</priority>", "0.5");
						xml.Append("</url>");
					}
				}
			}
		}


		xml.Append("</urlset> ");
		context.Response.Write(xml);
	}

	public bool IsReusable
	{
		get
		{
			return false;
		}
	}

	internal string GetFullPath(string path)
	{
		var request = HttpContext.Current.Request;
		return (new Uri(request.Url, System.IO.Path.Combine(request.ApplicationPath, path))).ToString();
	}
}