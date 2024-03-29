﻿using Domain.Entities;
using Domain.Enums;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infraestructure.Productos
{
    public class ProductoModel
    {
        private Producto[] productos;

        #region CRUD

        public void Add (Producto p)
        {
            Add(p, ref productos);
        }

        public int Update(Producto p)
        {
            int index = (GetIndexById(p));
            if ( index > 0)
            {
                throw new Exception($"El producto con Id {p.Id} No se encontro.");
            }

            productos[index] = p;
            return index;
        } 

        public bool Delete(Producto p)
        {
            int index = (GetIndexById(p));
            if (index > 0)
            {
                throw new Exception($"El producto con Id {p.Id} No se encontro.");
            }

            if (index != productos.Length - 1)
            {
                productos[index] = productos[productos.Length - 1];

            }
            Producto[] tmp = new Producto[productos.Length - 1];
            Array.Copy(productos, tmp, tmp.Length);
            productos = tmp;

            return productos.Length == tmp.Length;
        }

        public Producto[] GetAll()
        {
            return productos;
        }

        #endregion

        #region Queries

        public Producto[] GetProductosById(int id)
        {
            Producto[] tmp = null;

            if ( productos == null)
            {
                return tmp;
            }

            foreach (Producto p in productos)
            {
                if ( p.Id == id)
                {
                    Add(p, ref tmp);
                }
            }
            return tmp;
        }

        public Producto Actualizar(int id)
        {
            Producto tmp = null;

            if (productos == null)
            {
                return tmp;
            }

            foreach (Producto p in productos)
            {
                if (p.Id == id)
                {
                    Add(p);
                }
            }
            return tmp;
        }

        public Producto[] GetProductosByUnidadMedida(UnidadMedida um)
        {
            Producto[] tmp = null;

            if (productos == null)
            {
                return tmp;
            }
            
            foreach (Producto p in productos)
            {
                if (p.UnidadMedida == um)
                {
                    Add(p, ref tmp);
                }
            }

            return tmp;
        }

        public Producto[] GetProductosByFechaVencimiento(DateTime dt)
        {
            Producto[] tmp = null;

            if (productos == null)
            {
                return tmp;
            }

            foreach(Producto p in productos)
            {
                if (p.Vencimiento.CompareTo(dt) <= 0)
                {
                    Add(p, ref tmp);
                }
            }

            return tmp;
        }

        public Producto[] GetProductosByRangoPrecio(decimal start, decimal end)
        {
            Producto[] tmp = null;

            if (productos == null)
            {
                return tmp;
            }

            foreach (Producto p in productos)
            {
                if (p.Precio >= start && p.Precio <= end)
                {
                    Add(p, ref tmp);
                }
            }
            return tmp;
        }

        public string GetProductosAsJason(Producto producto)
        {
            return JsonConvert.SerializeObject(productos);
        }

        public string ConvertirBusqueda(Producto[] p)
        {
            return JsonConvert.SerializeObject(p);
        }

        public Producto[] GetProductosOrderByPrecio()
        {
            Array.Sort(productos, new Producto.ProductoOrderByPrecio());
            return productos;
        }

        public int GetLastProductId()
        {
            return productos == null ? 0 : productos[productos.Length - 1].Id;
        }

        #endregion

        #region Private Methods

        private void Add (Producto p, ref Producto[] pds)
        {
            if ( pds == null)
            {
                pds = new Producto[1];
                pds[pds.Length - 1] = p;
                return;
            }
            Producto[] tmp = new Producto[pds.Length + 1];
            Array.Copy(pds, tmp, pds.Length);
            pds = tmp;
        }

        private int GetIndexById(Producto p)
        {
            if ( p == null)
            {
                throw new ArgumentException("El producto no puede ser null");
            }
            int index = int.MinValue;
            if ( productos == null)
            {
                return index;
            }
            int i = 0;
            foreach (Producto pd in productos)
            {
                if ( pd.Id == p.Id)
                {
                    index = i;
                    break;
                }
                i++;
            }
            
            return index;
        }

        #endregion
    }
}
