﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by a CodeSmith Template.
//
//     DO NOT MODIFY contents of this file. Changes to this
//     file will be lost if the code is regenerated.
// </autogenerated>
//------------------------------------------------------------------------------
using System;
using System.Linq;

namespace Tracker.Core.Data.Interfaces
{
    /// <summary>
    /// Interface representing the dbo.Guid table.
    /// </summary>
    public interface IGuid
    {
        /// <summary>
        /// Gets or sets the Id column value.
        /// </summary>
        System.Guid Id { get; set; }
        /// <summary>
        /// Gets or sets the AlternateId column value.
        /// </summary>
        Nullable<System.Guid> AlternateId { get; set; }
        /// <summary>
        /// Gets or sets the Key column value.
        /// </summary>
        System.Guid Key { get; set; }
    }
}
