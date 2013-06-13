#region License

// Copyright (c) 2013, ClearCanvas Inc.
// All rights reserved.
// http://www.clearcanvas.ca
//
// This file is part of the ClearCanvas RIS/PACS open source project.
//
// The ClearCanvas RIS/PACS open source project is free software: you can
// redistribute it and/or modify it under the terms of the GNU General Public
// License as published by the Free Software Foundation, either version 3 of the
// License, or (at your option) any later version.
//
// The ClearCanvas RIS/PACS open source project is distributed in the hope that it
// will be useful, but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU General
// Public License for more details.
//
// You should have received a copy of the GNU General Public License along with
// the ClearCanvas RIS/PACS open source project.  If not, see
// <http://www.gnu.org/licenses/>.

#endregion

// This file is auto-generated by the ClearCanvas.Model.SqlServer.CodeGenerator project.

namespace ClearCanvas.ImageServer.Model.EntityBrokers
{
    using System;
    using System.Xml;
    using ClearCanvas.Dicom;
    using ClearCanvas.ImageServer.Enterprise;

   public partial class WorkQueueUidUpdateColumns : EntityUpdateColumns
   {
       public WorkQueueUidUpdateColumns()
       : base("WorkQueueUid")
       {}
        [EntityFieldDatabaseMappingAttribute(TableName="WorkQueueUid", ColumnName="WorkQueueGUID")]
        public ServerEntityKey WorkQueueKey
        {
            set { SubParameters["WorkQueueKey"] = new EntityUpdateColumn<ServerEntityKey>("WorkQueueKey", value); }
        }
        [EntityFieldDatabaseMappingAttribute(TableName="WorkQueueUid", ColumnName="FailureCount")]
        public Int16 FailureCount
        {
            set { SubParameters["FailureCount"] = new EntityUpdateColumn<Int16>("FailureCount", value); }
        }
        [EntityFieldDatabaseMappingAttribute(TableName="WorkQueueUid", ColumnName="Failed")]
        public Boolean Failed
        {
            set { SubParameters["Failed"] = new EntityUpdateColumn<Boolean>("Failed", value); }
        }
        [EntityFieldDatabaseMappingAttribute(TableName="WorkQueueUid", ColumnName="Duplicate")]
        public Boolean Duplicate
        {
            set { SubParameters["Duplicate"] = new EntityUpdateColumn<Boolean>("Duplicate", value); }
        }
        [EntityFieldDatabaseMappingAttribute(TableName="WorkQueueUid", ColumnName="Extension")]
        public String Extension
        {
            set { SubParameters["Extension"] = new EntityUpdateColumn<String>("Extension", value); }
        }
        [EntityFieldDatabaseMappingAttribute(TableName="WorkQueueUid", ColumnName="GroupID")]
        public String GroupID
        {
            set { SubParameters["GroupID"] = new EntityUpdateColumn<String>("GroupID", value); }
        }
        [EntityFieldDatabaseMappingAttribute(TableName="WorkQueueUid", ColumnName="RelativePath")]
        public String RelativePath
        {
            set { SubParameters["RelativePath"] = new EntityUpdateColumn<String>("RelativePath", value); }
        }
        [EntityFieldDatabaseMappingAttribute(TableName="WorkQueueUid", ColumnName="WorkQueueUidData")]
        public XmlDocument WorkQueueUidData
        {
            set { SubParameters["WorkQueueUidData"] = new EntityUpdateColumn<XmlDocument>("WorkQueueUidData", value); }
        }
       [DicomField(DicomTags.SeriesInstanceUid, DefaultValue = DicomFieldDefault.Null)]
        [EntityFieldDatabaseMappingAttribute(TableName="WorkQueueUid", ColumnName="SeriesInstanceUid")]
        public String SeriesInstanceUid
        {
            set { SubParameters["SeriesInstanceUid"] = new EntityUpdateColumn<String>("SeriesInstanceUid", value); }
        }
       [DicomField(DicomTags.SopInstanceUid, DefaultValue = DicomFieldDefault.Null)]
        [EntityFieldDatabaseMappingAttribute(TableName="WorkQueueUid", ColumnName="SopInstanceUid")]
        public String SopInstanceUid
        {
            set { SubParameters["SopInstanceUid"] = new EntityUpdateColumn<String>("SopInstanceUid", value); }
        }
    }
}
