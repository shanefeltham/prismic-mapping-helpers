﻿using System.Reflection;
using prismic;

namespace benembery.PrismicMapping.Core
{
    public class PrismicUidAttribute : PrismicFieldAttribute
    {
        protected override object GetValue(Document document, string documentName, PropertyInfo property)
        {
            return document.Uid;
        }
    }
}