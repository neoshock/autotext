﻿/*This file is part of AutoText.

Copyright © 2016 Alexander Litvinov

AutoText is free software; you can redistribute it and/or
modify it under the terms of the GNU General Public License
as published by the Free Software Foundation; either version 2
of the License, or (at your option) any later version.

This program is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License
along with this program; if not, write to the Free Software
Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301, USA.
 */


using System.Collections.Generic;
using System.Xml.Serialization;

namespace AutoText.Model.Configuration
{
	[XmlRoot("expressionsConfiguration", IsNullable = false)]
	public class ExpressionConfiguration
	{
		[XmlElement("expressionNameSuffixStr")]
		public string ExpressionNameSuffix { get; set; }
		[XmlElement("expressionParameterPrefix")]
		public string ExpressionParameterPrefix { get; set; }
		[XmlElement("expressionParameterAssignmentStr")]
		public string ExpressionParameterAssigmentString { get; set; }
		[XmlElement("shortcutRegex")]
		public string ShortcutRegexTemplate { get; set; }
		[XmlElement("nonPrintableTriggers")]
		public string NonPrintableTriggers { get; set; }
		[XmlArray("expressionDefinitions"), XmlArrayItem("expression")]
		public List<ExpressionConfigDefinition> ExpressionDefinitions { get; set; }

	}
}
