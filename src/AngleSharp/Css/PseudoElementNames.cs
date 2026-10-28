namespace AngleSharp.Css
{
    using System;

    /// <summary>
    /// The collection of (known / used) selector pseudo element names.
    /// </summary>
    public static class PseudoElementNames
    {
        /// <summary>
        /// The before pseudo element.
        /// </summary>
        public static readonly String Before = "before";

        /// <summary>
        /// The after pseudo element.
        /// </summary>
        public static readonly String After = "after";

        /// <summary>
        /// The slotted pseudo element.
        /// </summary>
        public static readonly String Slotted = "slotted";

        /// <summary>
        /// The selection pseudo element.
        /// </summary>
        public static readonly String Selection = "selection";

        /// <summary>
        /// The first-line pseudo element.
        /// </summary>
        public static readonly String FirstLine = "first-line";

        /// <summary>
        /// The first-letter pseudo element.
        /// </summary>
        public static readonly String FirstLetter = "first-letter";

        /// <summary>
        /// The footnote-call pseudo element.
        /// </summary>
        public static readonly String FootnoteCall = "footnote-call";

        /// <summary>
        /// The footnote-marker pseudo element.
        /// </summary>
        public static readonly String FootnoteMarker = "footnote-marker";

        /// <summary>
        /// The content pseudo element.
        /// </summary>
        public static readonly String Content = "content";

        /// <summary>
        /// The checkmark pseudo element.
        /// </summary>
        public static readonly String Checkmark = "checkmark";

        /// <summary>
        /// The picker-icon pseudo element.
        /// </summary>
        public static readonly String PickerIcon = "picker-icon";

        /// <summary>
        /// The picker pseudo element function.
        /// </summary>
        public static readonly String Picker = "picker";

        /// <summary>
        /// The placeholder pseudo element of a form control (CSS Pseudo 4 §4.5).
        /// </summary>
        public static readonly String Placeholder = "placeholder";

        /// <summary>
        /// The <c>::file-selector-button</c> pseudo element (CSS Forms 1 §4.2).
        /// </summary>
        public static readonly String FileSelectorButton = "file-selector-button";

        /// <summary>
        /// The <c>::details-content</c> pseudo element (CSS Pseudo 4 §4.8).
        /// </summary>
        public static readonly String DetailsContent = "details-content";

        /// <summary>
        /// The slider thumb of a range input, as the vendor spelling names it.
        /// </summary>
        public static readonly String SliderThumb = "-webkit-slider-thumb";

        /// <summary>
        /// The track a range input's thumb runs along, as the vendor spelling names it.
        /// </summary>
        public static readonly String SliderRunnableTrack = "-webkit-slider-runnable-track";

        /// <summary>
        /// The file upload button's vendor spelling, which is the old name of the same box.
        /// </summary>
        public static readonly String FileUploadButton = "-webkit-file-upload-button";

        /// <summary>
        /// The separating double-colon.
        /// </summary>
        public static readonly String Separator = "::";
    }
}
