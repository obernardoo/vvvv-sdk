﻿using CefGlue;

namespace VVVV.Nodes.Texture.HTML
{
    internal sealed class SchemeHandlerFactory : CefSchemeHandlerFactory
    {
        protected override CefSchemeHandler Create(CefBrowser browser, string schemeName, CefRequest request)
        {
            return new SchemeHandler();
        }
    }
}
