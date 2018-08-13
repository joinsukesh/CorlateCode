namespace Corlate.Feature.Metadata.Models
{
    using Sitecore.Data.Items;

    public class Metadata : CustomItem
    {
        
        public Metadata(Item innerItem) : base(innerItem)
        {
        }

        /// <summary>
        /// Gets the TitleID
        /// </summary>
        public string TitleID
        {
            get
            {
                return References.Templates.Metadata.Fields.Title.ToString();
            }
        }

        /// <summary>
        /// Gets the Title
        /// </summary>
        public string Title
        {
            get
            {
                return InnerItem.Fields[References.Templates.Metadata.Fields.Title].Value;
            }
        }

        /// <summary>
        /// Gets the DescriptionID
        /// </summary>
        public string DescriptionID
        {
            get
            {
                return References.Templates.Metadata.Fields.Description.ToString();
            }
        }

        /// <summary>
        /// Gets the Description
        /// </summary>
        public string Description
        {
            get
            {
                return InnerItem.Fields[References.Templates.Metadata.Fields.Description].Value;
            }
        }

        /// <summary>
        /// Gets the KeywordsID
        /// </summary>
        public string KeywordsID
        {
            get
            {
                return References.Templates.Metadata.Fields.Keywords.ToString();
            }
        }

        /// <summary>
        /// Gets the Keywords
        /// </summary>
        public string Keywords
        {
            get
            {
                return InnerItem.Fields[References.Templates.Metadata.Fields.Keywords].Value;
            }
        }
    }
}
