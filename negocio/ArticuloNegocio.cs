using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;
using System.Data.SqlClient;


namespace negocio
{
    public class ArticuloNegocio
    {
        public List<Articulo> listar()
        {
            List<Articulo> lista = new List<Articulo>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;
            try
            {
                conexion.ConnectionString = "server=.\\SQLEXPRESS; database = CATALOGO_DB; integrated security = true";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "select Codigo, Nombre, A.Descripcion, M.Descripcion Empresa, C.Descripcion Categorias, ImagenUrl, Precio, A.IdMarca, A.IdCategoria, A.Id from Articulos A, MARCAS M, Categorias C where A.IdMarca = M.Id and A.IdMarca = C.Id";
                comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();
                while (lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Id = (int)lector["Id"];
                    aux.Codigo = (string)lector["Codigo"];
                    aux.Nombre = (string)lector["Nombre"];
                    aux.Descripcion = (string)lector["Descripcion"];
                    aux.Empresa = new Marca();
                    aux.Empresa.Descripcion = (string)lector["Empresa"];
                    aux.Empresa.Id = (int)lector["IdMarca"];
                    aux.Categorias = new Categoria();
                    aux.Categorias.Descripcion = (string)lector["Categorias"];
                    aux.Categorias.Id = (int)lector["IdCategoria"];
                    aux.ImagenUrl = (string)lector["ImagenUrl"];
                    
                    if (!(lector["Precio"] is DBNull))
                    aux.Precio = (decimal)lector["Precio"];
                    
                    lista.Add(aux);
                }
                conexion.Close();
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public void agregar(Articulo alta)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                //datos.setearConsulta("Insert Into Articulos (Codigo, Nombre, Descripcion, IdMarca, IdCategoria, ImagenUrl, Precio ) values ('" + alta.Codigo + "', '" + alta.Nombre + "', '" + alta.Descripcion + "')");
                datos.setearConsulta("Insert Into Articulos (Codigo, Nombre, Descripcion, IdMarca, IdCategoria, ImagenUrl, Precio) values (@codigo, @nombre, @descripcion, @idMarca, @idCategoria, @imagenUrl, @precio)");
                datos.setearParametros("@codigo", alta.Codigo);
                datos.setearParametros("@nombre", alta.Nombre);
                datos.setearParametros("@descripcion", alta.Descripcion);
                datos.setearParametros("@idMarca", alta.Empresa.Id);
                datos.setearParametros("@idCategoria", alta.Categorias.Id);
                datos.setearParametros("@imagenUrl", alta.ImagenUrl);
                datos.setearParametros("@precio", alta.Precio);
              
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
        public void modificar(Articulo modificar)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("update ARTICULOS set Codigo =@codigo, Nombre =@nombre, Descripcion=@descripcion, IdMarca =@IdMarca, IdCategoria=@IdCategoria, ImagenUrl=@imagenUrl, Precio=@precio where Id=@Id");
                datos.setearParametros("@codigo", modificar.Codigo);
                datos.setearParametros("@nombre", modificar.Nombre);
                datos.setearParametros("@descripcion", modificar.Descripcion);
                datos.setearParametros("@IdMarca", modificar.Empresa.Id);
                datos.setearParametros("@IdCategoria", modificar.Categorias.Id);
                datos.setearParametros("@imagenUrl", modificar.ImagenUrl);
                datos.setearParametros("@precio", modificar.Precio);
                datos.setearParametros("@Id", modificar.Id);

                datos.ejecutarAccion();


            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public List<Articulo> filtrar(string campo, string criterio, string filtro)
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();
            try
            {

                string consulta = "select Codigo, Nombre, A.Descripcion, M.Descripcion Empresa, C.Descripcion Categorias, ImagenUrl, Precio, A.IdMarca, A.IdCategoria, A.Id from Articulos A, MARCAS M, Categorias C where A.IdMarca = M.Id and A.IdMarca = C.Id and ";
                if (campo == "Precio")
                {
                    switch (criterio)
                    {
                        case "Es mayor que":
                            consulta += "Precio > " + filtro;
                            break;
                        case "Es menor que":
                            consulta += "Precio < " + filtro;
                            break;
                        default:
                            consulta += "Precio = " + filtro;
                            break;
                    }
                }
                else if (campo == "Nombre")
                {
                    switch (criterio)
                    {
                        case "Empieza con":
                            consulta += "Nombre like '" + filtro + "%'";
                                        
                            break;
                        case "Termina con":
                            consulta += "Nombre like '%" + filtro + "'";
                            break;
                        default:
                            consulta += "Nombre like '%" + filtro + "%'";
                            break;
                    }
                }
                else
                {
                    switch (criterio)
                    {
                        case "Empieza con":
                            consulta += "C.Descripcion like '" + filtro + "%'";
                            break;
                        case "Termina con":
                            consulta += "C.Descripcion like '%" + filtro + "'";
                            break;
                        default:
                            consulta += "C.Descripcion like '%" + filtro + "%'";
                            break;
                    }
                }
                datos.setearConsulta(consulta);
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Codigo = (string)datos.Lector["Codigo"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    aux.Empresa = new Marca();
                    aux.Empresa.Descripcion = (string)datos.Lector["Empresa"];
                    aux.Empresa.Id = (int)datos.Lector["IdMarca"];
                    aux.Categorias = new Categoria();
                    aux.Categorias.Descripcion = (string)datos.Lector["Categorias"];
                    aux.Categorias.Id = (int)datos.Lector["IdCategoria"];
                    if (!(datos.Lector["ImagenUrl"] is DBNull))
                    aux.ImagenUrl = (string)datos.Lector["ImagenUrl"];

                    if (!(datos.Lector["Precio"] is DBNull))
                        aux.Precio = (decimal)datos.Lector["Precio"];

                    lista.Add(aux);
                }
                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void eliminar(int id)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("Delete from Articulos where Id=@id");
                datos.setearParametros("@Id", id);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }

   
}
