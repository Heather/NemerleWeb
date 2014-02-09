﻿using System.Collections.Generic;
using System.Web;
using System.Web.Routing;

namespace Rsdn.NavTree
{
    public interface INavTreeProvider
    {
        IEnumerable<NodeData> GetChildren(string parentID, HttpRequest requestContext);
        IEnumerable<NodeData> LoadByIds(IEnumerable<string> ids, HttpRequest requestContext);
        IEnumerable<NodeData> Search(string term, HttpRequest requestContext);
        IEnumerable<NodeInfo> FindNodesByUrl(string url, RequestContext context);
    }
}