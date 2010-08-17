using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataTiers.SqlClient.Entities {
    public class Categories {

        private CategoriesEntityData entityData;

        public Categories() {
            entityData = new CategoriesEntityData();
        }

        public Categories(CategoriesEntityData entityData) {
            this.entityData = entityData;
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
    }


    public class CategoriesEntityData {
        public Int32 _CategoryId;
        public String _CategoryName = string.Empty;
        public String _Description = null;
        public Byte[] _Picture = null;

        public Int32 CategoryId {
            get {
                return _CategoryId;
            }
            set {
                _CategoryId = value;
            }
        }

        public String CategoryName {
            get {
                return _CategoryName;
            }
            set {
                _CategoryName = value;
            }
        }

        public String Description {
            get {
                return _Description;
            }
            set {
                _Description = value;
            }
        }

        public Byte[] Picture {
            get {
                return _Picture;
            }
            set {
                _Picture = value;
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
