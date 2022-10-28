﻿using System;

namespace ctLite.Types
{
    /// <summary>
    /// Provides a visual representation type for this field. It is only relevant for string-based field types like StringType and LocalizedStringType.
    /// </summary>
    /// <see href="http://dev.commercetools.com/http-api-projects-types.html#textinputhint"/>
    public enum TextInputHint
    {
        SingleLine,
        MultiLine
    }
}
