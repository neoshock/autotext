﻿using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace AutoText.Helpers.Configuration
{
	public class AutotextRuleConfig
	{
		[XmlElement("abbreviation")]
		public RuleAbbreviation Abbreviation { get;  set; }
		[XmlElement("phrase")]
		public string Phrase { get;  set; }
		[XmlElement("description")]
		public string Description { get;  set; }

		[XmlArray("triggers")]
		[XmlArrayItem("item", typeof(AutotextRuleTrigger))]
		public List<AutotextRuleTrigger> Triggers { get;  set; }
	}
}