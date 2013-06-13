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

namespace ClearCanvas.ImageServer.Model
{
    using System;
    using System.Xml;
    using ClearCanvas.Enterprise.Core;
    using ClearCanvas.ImageServer.Enterprise;
    using ClearCanvas.ImageServer.Common.Command;
    using ClearCanvas.ImageServer.Model.EntityBrokers;

    [Serializable]
    public partial class CannedText: ServerEntity
    {
        #region Constructors
        public CannedText():base("CannedText")
        {}
        public CannedText(
             String _label_
            ,String _category_
            ,String _text_
            ):base("CannedText")
        {
            Label = _label_;
            Category = _category_;
            Text = _text_;
        }
        #endregion

        #region Public Properties
        [EntityFieldDatabaseMappingAttribute(TableName="CannedText", ColumnName="Label")]
        public String Label
        { get; set; }
        [EntityFieldDatabaseMappingAttribute(TableName="CannedText", ColumnName="Category")]
        public String Category
        { get; set; }
        [EntityFieldDatabaseMappingAttribute(TableName="CannedText", ColumnName="Text")]
        public String Text
        { get; set; }
        #endregion

        #region Static Methods
        static public CannedText Load(ServerEntityKey key)
        {
            using (var context = new ServerExecutionContext())
            {
                return Load(context.ReadContext, key);
            }
        }
        static public CannedText Load(IPersistenceContext read, ServerEntityKey key)
        {
            var broker = read.GetBroker<ICannedTextEntityBroker>();
            CannedText theObject = broker.Load(key);
            return theObject;
        }
        static public CannedText Insert(CannedText entity)
        {
            using (var update = PersistentStoreRegistry.GetDefaultStore().OpenUpdateContext(UpdateContextSyncMode.Flush))
            {
                CannedText newEntity = Insert(update, entity);
                update.Commit();
                return newEntity;
            }
        }
        static public CannedText Insert(IUpdateContext update, CannedText entity)
        {
            var broker = update.GetBroker<ICannedTextEntityBroker>();
            var updateColumns = new CannedTextUpdateColumns();
            updateColumns.Label = entity.Label;
            updateColumns.Category = entity.Category;
            updateColumns.Text = entity.Text;
            CannedText newEntity = broker.Insert(updateColumns);
            return newEntity;
        }
        #endregion
    }
}
