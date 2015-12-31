﻿using System.Collections.Generic;
using System.Text;
using Tools.Convert.Data;

namespace Tools.Convert
{
    public class GenerateFileFromJson
    {
        Data.RootObject _root;
        StringBuilder sb = new StringBuilder();
        string _name => _root.title.Replace(" ", "");

        public GenerateFileFromJson(Data.RootObject root)
        {
            _root = root;
        }

        public string Convert()
        {
            sb = new StringBuilder();
            AddHeader();
            foreach (var item in _root.properties)
            {
                AddItem(item.Key, item.Value);
            }
            AddFooter();

            return sb.ToString();
        }

        private void AddItem(string name, Item item)
        {
            if (name == "href")
                return;//this is already available in the base class (ResultBase)

            string type = GetType(item, item.type, name);

            if (item.properties != null || type == "object")
                return; //it will cost to much effort to create a generic way of adding these properties to a nice class

            string indent = "            ";
            sb.AppendLine($"{indent}/// <summary>");
            sb.AppendLine($"{indent}/// <summary>");
            sb.AppendLine($"{indent}/// {item.description}");
            if (item.minimum.HasValue)
                sb.AppendLine($"{indent}/// Minimum: {item.minimum.Value}");
            if (item.maximum.HasValue)
                sb.AppendLine($"{indent}/// Maximum: {item.maximum.Value}");
            if (item.maxlength.HasValue)
                sb.AppendLine($"{indent}/// Maxlength: {item.maxlength.Value}");
            sb.AppendLine($"{indent}/// </summary>");

            AddEnumDescription(item.Enum);

            sb.AppendLine($"{indent}public {type} {name} {{ get; set; }}");
            sb.AppendLine("");
        }

        private string GetType(Item item, string type, string name)
        {   
            if (item.format == "uri")
                return "Uri";
            if (item.format == "date-time")
                return "DateTime";

            if (type.StartsWith("integer"))
            {
                if (name == "id")
                    return "int";
                return "int?";
            }
            if (type.StartsWith("string"))
                return "string";
            if (type.StartsWith("boolean"))
                return "bool?";
            if (type.StartsWith("number"))
                return "double?";

            return type;
        }

        private void AddEnumDescription(List<string> enumval)
        {
            if (enumval == null)
                return;

            foreach (var val in enumval)
            {
                sb.AppendLine($"        /// <value>{val}</value>");
            }
        }

        private void AddFooter()
        {
            sb.AppendLine("    }");
            sb.AppendLine("}");
        }

        private void AddHeader()
        {
            sb.AppendLine("using Connector.CcvShop.Api.Base;");
            sb.AppendLine("using System;");
            sb.AppendLine("");
            sb.AppendLine("// This file is generated by the Converttool in the solution Connector.CcvShop.");
            sb.AppendLine($"namespace Connector.CcvShop.Api.{_name}");
            sb.AppendLine("{");
            sb.AppendLine($"        public class {_name}Result : ResultBase");
            sb.AppendLine("        {");
        }
    }
}
