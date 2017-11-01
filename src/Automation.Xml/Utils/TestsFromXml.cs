﻿using System.Xml.Serialization;
using System.Collections.Generic;

namespace Automation.Xml.Utils
{
    [XmlRoot("tests")]
    internal class TestsFromXml
    {
        [XmlElement("test")]
        public List<Tests> ListOfTests { get; set; }

        public class Tests
        {
            [XmlAttribute("testsuite")]
            public string TestSuite { get; set; }

            [XmlAttribute("testname")]
            public string TestName { get; set; }

            [XmlAttribute("testcasedescription")]
            public string TestCaseDescription { get; set; }
        }
    }
}