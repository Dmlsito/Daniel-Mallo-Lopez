package org.example;

import java.sql.*;

import static org.example.Conexion.obtenerConexion;

/**
 * Hello world!
 *
 */
public class App 
{
    public static void main( String[] args ) throws SQLException {
      crearTabla();


    }

    //Metodo para generar la conexion
    public static Connection conexionBBDD() throws SQLException {
        String conexion= "jdbc:sqlserver://localhost:1433;"
                +"database=Prueba;"
                +"user=sa;"
                +"password=admin;"
                +"encrypt=true;"
                +"trustServerCertificate=true;"
                +"loginTimeout=30;";

        try{
            Connection conexionBBDD = DriverManager.getConnection(conexion);
            System.out.println("La conexion a la BBDD ha sido un exito");
            return conexionBBDD;
        }catch(SQLException e){
            System.out.println("Ha ocurrido un fallo al intentar conectarse a la BBDD");
            throw new RuntimeException(e);
        }

    }

    //Metodo para crear una tabla
    public static void crearTabla() throws SQLException{

        Connection c = Conexion.obtenerConexion();
        Statement s = null;

        try{
            String sql = "CREATE TABLE Jugadores ("
                    +"id int IDENTITY(1,1) PRIMARY KEY,"
                    +"Nombre varchar(20) NOT NULL,"
                    +"Dorsal int NOT NULL)";
            s = c.createStatement();
            s.executeUpdate(sql);
            System.out.println("La tabla se ha creado con exito");
        }catch(SQLException e){
            System.out.println("Ha ocurrido un error al crear la tabla");
            throw new RuntimeException(e);
        }finally{
            //Cerramos la conexion
            if(c != null) c.close();
            if(s != null) s.close();
        }
    }

    //Metodo para insertar jugadores

    public static void insertarJugadores() throws SQLException {

        Connection c = obtenerConexion();
        PreparedStatement p = null;

        try{
            String sql = "INSERT INTO Jugadores (Nombre, Dorsal) VALUES (?, ?)";
            p = c.prepareStatement(sql);
            p.setString(1,"Daniel");
            p.setInt(2, 4);
            p.executeUpdate();
            System.out.println("Se han creado los campos ");

        }catch(SQLException e){
            System.out.println("No se han podido insertar valores en los campos");
            throw new RuntimeException(e);
        }finally{
            if(c != null) c.close();
            if(p != null) p.close();
        }
    }

    //Procedimientos almacenados y transacciones






}
