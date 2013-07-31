﻿using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Web.Http;
using System.Web.Http.ModelBinding;
using Umbraco.Core.Models;

namespace Umbraco.Web.Models.ContentEditing
{
    /// <summary>
    /// A model representing a content item to be displayed in the back office
    /// </summary>    
    [DataContract(Name = "content", Namespace = "")]
    public class ContentItemDisplay : ContentItemDisplayBase<ContentPropertyDisplay, IContent>
    {
        
        [DataMember(Name = "publishDate")]
        public DateTime? PublishDate { get; set; }
        
    }
}