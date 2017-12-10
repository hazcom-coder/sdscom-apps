using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SDSComApp.Models
{
	public class EuphracPhrase
	{
		public EuphracPhrase(){}
		public string EuPhraCStructureCode {get; set;} 
		public string XPath {get; set;}
		public string Region {get; set;}
		public string EuPhraCPhraseID {get; set;}
		public string Grammar {get; set;}
		public string OriginalCode {get; set;}
		public string English {get; set;}
		public string German {get; set;}
		public string RevisionDate {get; set;}
		public string Source {get; set;}
		public string Info { get; set; }
	}
}