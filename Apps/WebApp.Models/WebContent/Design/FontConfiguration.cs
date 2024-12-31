﻿using JLI.Framework.Data;
using System.ComponentModel.DataAnnotations;

namespace WebApp.Models.WebContent.Design {

    public class FontConfiguration {

        [Range(6, 128)]
        public byte Size { get; set; } = 16;

        [Required, FormalNameLength]
        public string Name { get; set; } = "Roboto";

        public FontWeights Weight { get; set; } = FontWeights.Normal;

        [Display(Name = "Line Height")]
        public LineHeights LineHeight { get; set; } = LineHeights.OneHundredThrityThree;

    }

}
