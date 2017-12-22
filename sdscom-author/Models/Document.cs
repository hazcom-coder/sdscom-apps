using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SDSComApps.Models
{
    /// <summary>
    /// 
    /// </summary>
	public class Document
	{
        /// <summary>
        /// 
        /// </summary>
		public Document() { }

        /// <summary>
        /// 
        /// </summary>
		public string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
		public List<Chapter> Chapters { get; set; }
	}

    /// <summary>
    /// 
    /// </summary>
	public class Chapter : BaseDocumentItem
	{
        /// <summary>
        /// 
        /// </summary>
		public Chapter() { }
		
        /// <summary>
        /// 
        /// </summary>
		public List<ChapterMember> ChapterMembers { get; set; }
	}

    /// <summary>
    /// 
    /// </summary>
	public class ChapterMember : BaseDocumentItem
	{
        /// <summary>
        /// 
        /// </summary>
		public ChapterMember() { }
	
        /// <summary>
        /// 
        /// </summary>
		public ChoiceItem ChoiceElement { get; set; }

        /// <summary>
        /// 
        /// </summary>
		public List<ChapterMemberItem> ChapterMemberItems { get; set; }
	}

    /// <summary>
    /// 
    /// </summary>
	public class ChapterMemberItem : BaseDocumentItem
	{
        /// <summary>
        /// 
        /// </summary>
		public ChapterMemberItem() { }

        /// <summary>
        /// 
        /// </summary>
		public List<ChapterMemberItemDetail> ChapterMemberItemDetails { get; set; }
	}

    /// <summary>
    /// 
    /// </summary>
	public class ChapterMemberItemDetail : BaseDocumentItem
	{
        /// <summary>
        /// 
        /// </summary>
		public ChapterMemberItemDetail() { }

        /// <summary>
        /// 
        /// </summary>
		public List<ChapterMemberItemDetailProperty> ChapterMemberItemDetailProperties { get; set; }
	}

    /// <summary>
    /// 
    /// </summary>
	public class ChapterMemberItemDetailProperty : BaseDocumentItem
	{
        /// <summary>
        /// 
        /// </summary>
		public ChapterMemberItemDetailProperty() { }

		
	}


    /// <summary>
    /// 
    /// </summary>
	public class ChoiceItem
	{
        /// <summary>
        /// 
        /// </summary>
		public ChoiceItem() { }

        /// <summary>
        /// 
        /// </summary>
		public string First { get; set; }

        /// <summary>
        /// 
        /// </summary>
		public string Second { get; set; }

	}

}