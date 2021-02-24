using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    //escribo todos los campos que va a tener la entidad.
    public class Productos
    {
         string Cod_Art_Pro; //completado
         decimal PU_Pro; //complteado
         decimal Stock; //complteado
         string Categoria; //complteado
         string Descripcion; //complteado
         bool Estado_Producto; //complteado    
         string Url_Imagen; //complteado  

        public void Cod_Art(string v)
        {
            throw new NotImplementedException();
        }

        // constructor
        public Productos()
        {

        }
        
        // getter & setter  ===== Codigo de articulo 

        public string getCod_Art_Pro()
        {
            return Cod_Art_Pro;
        }
        public void setCod_Art_Pro(string cod_Art_Pro)
        {
            Cod_Art_Pro = cod_Art_Pro;
        }

        // getter & setter  ===== Precio unitario 

        public decimal getPU_Pro()
        {
            return PU_Pro;
        }
        public void setPU_Pro(decimal pU_Pro)
        {
            PU_Pro = pU_Pro;
        }

        // getter & setter  ===== Stock

        public decimal getStock()
        {
            return Stock;
        }
        public void setStock(decimal stock)
        {
            Stock = stock;
        }

        // getter & setter  ===== Categoria

        public string getCategoria()
        {
            return Categoria;
        }
        public void setCategoria(string categoria)
        {
            Categoria = categoria;
        }

        // getter & setter  ===== Descripcion

        public string getDescripcion()
        {
            return Descripcion;
        }
        public void setDescripcion(string descripcion)
        {
            Descripcion = descripcion;
        }

        // getter & setter  ===== Estado_Producto

        public bool getEstado_Producto()
        {
            return Estado_Producto;
        }
        public void setEstado_Producto(bool estado_Producto)
        {
            Estado_Producto = estado_Producto;
        }

        // getter & setter  ===== Imagen

        public string getUrl_Imagen()
        {
            return Url_Imagen;
        }
        public void setUrl_Imagen(string url_Imagen)
        {
            Url_Imagen = url_Imagen;
        }

    }
}
