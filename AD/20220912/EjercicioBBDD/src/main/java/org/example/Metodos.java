package org.example;

import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.SQLException;
import java.sql.Statement;

public class Metodos {



    //Metodos para insertar jugadores
    public void insertarJugadores() throws SQLException {
        Connection c = Conexion.obtenerConexion();
        PreparedStatement p = null;

        try{
            String sql = "insert into Equipos (Nombre, Pais, Titulos, DiasPartido) values(?, ?, ?, ?, ?)";
            p = c.prepareStatement(sql);
            p.setString(1, "Oporto");
            p.setString(2,"Portugal");
            p.setInt(3, 81);
            p.setString(4, "VSD");
        }catch(SQLException e){
            System.out.println("Ha ocurrido un error al querer insertar los jugadores");
            throw new RuntimeException(e);
        }finally{
            //Cerramos la conexion
            if(c != null) c.close();
            if(p != null) p.close();
        }


    }
}
