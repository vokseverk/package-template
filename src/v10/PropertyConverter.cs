using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Umbraco.Extensions;
using Umbraco.Cms.Core;
using Umbraco.Cms.Core.Models;
using Umbraco.Cms.Core.PropertyEditors;
using Umbraco.Cms.Core.Models.PublishedContent;

namespace Vokseverk;

// TODO: Change class name here
public class EDITOR_ALIASPropertyConverter : IPropertyValueConverter {

	public bool IsConverter(IPublishedPropertyType propertyType) {
		// TODO: Change alias here
		return propertyType.EditorAlias.Equals("ORGANISATION_ALIAS.EDITOR_ALIAS");
	}

	public Type GetPropertyValueType(IPublishedPropertyType propertyType) {
		// TODO: Change Type here
		return typeof(string);
	}

	public PropertyCacheLevel GetPropertyCacheLevel(IPublishedPropertyType propertyType) {
		return PropertyCacheLevel.Element;
	}

	public bool? IsValue(object value, PropertyValueLevel level) {
		switch (level) {
			case PropertyValueLevel.Source:
				// TODO: Implement logic here
			return value != null && value is string;
			default:
				throw new NotSupportedException($"Invalid level: {level}.");
		}
	}

	public object ConvertSourceToIntermediate(IPublishedElement owner, IPublishedPropertyType propertyType, object source, bool preview) {
		// TODO: Implement
	}

	public object ConvertIntermediateToObject(IPublishedElement owner, IPublishedPropertyType propertyType, PropertyCacheLevel referenceCacheLevel, object inter, bool preview) {
		// TODO: Implement
	}

	public object ConvertIntermediateToXPath(IPublishedElement owner, IPublishedPropertyType propertyType, PropertyCacheLevel referenceCacheLevel, object inter, bool preview) {
		if (inter == null) {
			return null;
		}

		// TODO: Implement?

		return inter.ToString();
	}
}
