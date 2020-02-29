﻿using System;
using System.Collections.Generic;
using System.IO;

namespace BlazorWebView
{
    public class WebViewOptions
    {
        public IBlazorWebView Parent { get; set; }

        public IDictionary<string, ResolveWebResourceDelegate> SchemeHandlers { get; }
            = new Dictionary<string, ResolveWebResourceDelegate>();
    }

    public delegate Stream ResolveWebResourceDelegate(string url, out string contentType);
}
