﻿using Serenity.ComponentModel;
using System;

namespace Dashboard.Administration.Forms
{
    [ColumnsScript("Administration.Language")]
    [BasedOnRow(typeof(LanguageRow), CheckNames = true)]
    public class LanguageColumns
    {
        [EditLink]
        public String LanguageId { get; set; }
        [EditLink]
        public String LanguageName { get; set; }
    }
}