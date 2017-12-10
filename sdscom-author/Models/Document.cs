using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SDSComApp.Models
{
	public class Document
	{
		public Document() { }

		public string Name { get; set; }

		public List<Chapter> Chapters { get; set; }
	}

	public class Chapter : BaseDocumentItem
	{
		public Chapter() { }
		
		public List<ChapterMember> ChapterMembers { get; set; }
	}

	public class ChapterMember : BaseDocumentItem
	{
		public ChapterMember() { }
	
		public ChoiceItem ChoiceElement { get; set; }

		public List<ChapterMemberItem> ChapterMemberItems { get; set; }
	}

	public class ChapterMemberItem : BaseDocumentItem
	{
		public ChapterMemberItem() { }

		public List<ChapterMemberItemDetail> ChapterMemberItemDetails { get; set; }
	}


	public class ChapterMemberItemDetail : BaseDocumentItem
	{
		public ChapterMemberItemDetail() { }

		public List<ChapterMemberItemDetailProperty> ChapterMemberItemDetailProperties { get; set; }
	}

	public class ChapterMemberItemDetailProperty : BaseDocumentItem
	{
		public ChapterMemberItemDetailProperty() { }

		
	}
	public class ChoiceItem
	{
		public ChoiceItem() { }

		public string First { get; set; }

		public string Second { get; set; }

	}

}