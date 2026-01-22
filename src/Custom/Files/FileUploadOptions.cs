using System;
using System.Diagnostics.CodeAnalysis;

namespace OpenAI.Files;

/// <summary>
/// Represents additional options available when uploading a file.
/// </summary>
public class FileUploadOptions
{
    /// <summary>
    /// Creates a new instance of <see cref="FileUploadOptions"/>.
    /// </summary>
    public FileUploadOptions()
    {
    }

    /// <summary>
    /// Gets or sets the number of days after which the file will expire and be deleted.
    /// </summary>
    /// <remarks>
    /// <para>
    /// When set, the file will automatically expire and be deleted after the specified number of days
    /// following its creation. The expiration is calculated from the file's <c>created_at</c> timestamp.
    /// </para>
    /// <para>
    /// This property is optional. When not set (null), the file will not expire automatically.
    /// </para>
    /// </remarks>
    [Experimental("OPENAI001")]
    public int? ExpiresAfterDays { get; set; }
}
