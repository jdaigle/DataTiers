using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataTiers.SqlClient.Entities {
    public class Categories : IEntity {

        private CategoriesEntityData entityData;

        public Categories() {
            entityData = new CategoriesEntityData();
            entityData.EntityState = EntityState.New;
        }

        public Int32 CategoryId {
            get {
                return entityData.CategoryId;
            }
        }

        public String CategoryName {
            get {
                return entityData.CategoryName;
            }
            set {
                entityData.CategoryName = value;
            }
        }

        public String Description {
            get {
                return entityData.Description;
            }
            set {
                entityData.Description = value;
            }
        }

        public Byte[] Picture {
            get {
                return entityData.Picture;
            }
            set {
                entityData.Picture = value;
            }
        }

        IEntityData IEntity.EntityData {
            get { return entityData; }
        }
    }


    public class CategoriesEntityData : EntityDataBase {
        public Int32 _CategoryId;
        public String _CategoryName = string.Empty;
        public String _Description = null;
        public Byte[] _Picture = null;

        public Int32 CategoryId {
            get {
                return _CategoryId;
            }
            set {
                if (_CategoryId == value)
                    return;
                _CategoryId = value;
                OnDataChanged();
            }
        }

        public String CategoryName {
            get {
                return _CategoryName;
            }
            set {
                if (_CategoryName == value)
                    return;
                _CategoryName = value;
                OnDataChanged();
            }
        }

        public String Description {
            get {
                return _Description;
            }
            set {
                if (_Description == value)
                    return;
                _Description = value;
                OnDataChanged();
            }
        }

        public Byte[] Picture {
            get {
                return _Picture;
            }
            set {
                if (_Picture == value)
                    return;
                _Picture = value;
                OnDataChanged();
            }
        }
    }

    [Serializable]
    public enum CategoriesColumn : int {
        CategoryId = 1,
        CategoryName = 2,
        Description = 3,
        Picture = 4
    }

    public static class CategoriesColumnsHelper {
        public static string GetColumnName(CategoriesColumn column) {
            switch (column) {
                case CategoriesColumn.CategoryId:
                    return "CategoryId";
                case CategoriesColumn.CategoryName:
                    return "CategoryName";
                case CategoriesColumn.Description:
                    return "Description";
                case CategoriesColumn.Picture:
                    return "Picture";
            }
            throw new InvalidOperationException("Invalid Enumeration Value");
        }
    }
}
