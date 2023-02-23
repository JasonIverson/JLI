﻿using JLI.Framework.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApp.Models.WebContent.Resources;

namespace WebApp.Models.WebContent {

    public class PageTemplate : SoftDeleteModel {

        public ImageResource? FavIcon { get; set; }

        public InjectedContentList InjectedContent { get; set; } = new InjectedContentList();

        public PageTemplateMetadata Metadata { get; set; } = new PageTemplateMetadata();

    }
}
