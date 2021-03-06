﻿using System.Xml;
using ICSharpCode.AvalonEdit.Highlighting;
using ICSharpCode.AvalonEdit.Highlighting.Xshd;

namespace MattC.DockableCLArgs
{
    static class ResourceLoader
    {
        public static IHighlightingDefinition LoadHighlightingDefinition(string resourceName)
        {
            var type = typeof(ResourceLoader);
            var fullName = type.Namespace + "." + resourceName;

            var stream = type.Assembly.GetManifestResourceStream(fullName);
            using (var reader = new XmlTextReader(stream))
            {
                return HighlightingLoader.Load(reader, HighlightingManager.Instance);
            }

            //using (var reader = new XmlTextReader(resourceName))
            //{
            //    var xshd = HighlightingLoader.LoadXshd(reader);
            //    return HighlightingLoader.Load(xshd, HighlightingManager.Instance);
            //}
        }
    }
}
