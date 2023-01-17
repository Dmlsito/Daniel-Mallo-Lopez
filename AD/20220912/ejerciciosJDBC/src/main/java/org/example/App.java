package org.example;


import java.sql.*;

public class App
{
    public static void main( String[] args ) throws SQLException {
    conectorDB();

    }
    // Método para conectar con la BBDD
    public static Connection conectorDB(){
        String connectionUrl =
                "jdbc:sqlserver://localhost:1433;"
                        +"database=Pruebas;"
                        +"user=sa;"
                        +"password=admin;"
                        +"encrypt=true;"
                        +"trustServerCertificate=true;"
                        +"loginTimeout=5;";

        try{
            Connection connection = DriverManager.getConnection(connectionUrl);
            System.out.println("Conexión OK");
            return connection;
        }catch (SQLException e){
            System.out.println("Conexión KO");
            throw new RuntimeException(e);
        }


    }
    // Método para crear una tabla
    public static void crearTabla() throws SQLException{
        Connection c = conectorDB();
        Statement s = null;

        try{
            s= c.createStatement();
            String sentenciaDDL ="CREATE TABLE Jugadores ("
                    +"id int IDENTITY(1,1) PRIMARY KEY,"
                    +"nombre varchar(20) NOT NULL,"
                    +"dorsal int NOT NULL)";
            s.executeUpdate(sentenciaDDL);
            System.out.println("Crear tabla OK");


        }catch (SQLException e){
            System.out.println("Crear tabla KO");
            throw new RuntimeException(e);
        }finally {
            if(s!=null) s.close();
            if(c!=null) c.close();
        }

    }
    //Método para modificar la tabla y añadir un nuevo campo "Equipo"
    public static void modificarTabla() throws SQLException {
        Connection c = conectorDB();
        Statement s = null;

        try{
            s = c.createStatement();
            String sentenciaModificar="ALTER TABLE Jugadores "
                    +"ADD Equipo varchar(20)";
            s.executeUpdate(sentenciaModificar);
            System.out.println("Modificación OK");

        }catch (SQLException e){
            System.out.println("Modificación KO");
            throw new RuntimeException(e);
        }finally {
            if(s!=null) s.close();
            if(c!=null) c.close();
        }
    }
    public static void insertarJugador() throws SQLException{
        Connection c = conectorDB();
        PreparedStatement s = null;
        try{
            s = c.prepareStatement("INSERT INTO Jugadores (nombre, dorsal, equipo) VALUES (?,?,?)");
            s.setString(1,"Lucas");
            s.setInt(2,7);
            s.setString(3, "Deportivo");
            s.executeUpdate();
            System.out.println("Insertado Jugador OK");

        }catch ( SQLException e){
            System.out.println("Insertado Jugador KO");
            throw new RuntimeException(e);

        }finally {
            if(s!=null)s.close();
            if(c!=null)c.close();
        }
    }

    // Modificar datos de un Jugador
    public static void actualizarJugador (String nombre) throws SQLException{
        Connection c = conectorDB();
        PreparedStatement s = null;

        try{
            s = c.prepareStatement("UPDATE Jugadores set dorsal = ? WHERE nombre= ?");
            s.setInt(1,12);
            s.setString(2,nombre);
            s.executeUpdate();
            System.out.println("Actualizado el Jugador OK");

        }catch (SQLException e){
            System.out.println("Actualizado el Jugador KO");
            throw new RuntimeException(e);

        }finally {
            if(s!=null)s.close();
            if(c!=null)c.close();
        }
    }

    // Método para borrar Jugadores
    public static void borrarJugador () throws SQLException {

        Connection c = conectorDB();
        PreparedStatement s = null;

        try{
            s = c.prepareStatement("DELETE FROM Jugadores WHERE nombre = ?;");
            s.setString(1,"Lucas");
            s.executeUpdate();
            System.out.println("Eliminar el Jugador OK");

        }catch (SQLException e){
            System.out.println("Eliminar el Jugador KO");
            throw new RuntimeException(e);

        }finally {
            if(s!=null)s.close();
            if(c!=null)c.close();
        }

    }
    // Método para consultar jugadores
    public static void buscarJugadores () throws SQLException {

        Connection c = conectorDB();
        PreparedStatement s = null;

        try{
            s = c.prepareStatement("SELECT * FROM Jugadores WHERE nombre = ?");
            s.setString(1,"Lucas");
            ResultSet res = s.executeQuery();

            while(res.next()){
                String impresion ="ID="
                        +res.getInt("id")
                        + " ,Nombre = "
                        +res.getString("nombre")
                        + " ,Dorsal = "
                        +res.getInt("dorsal")
                        +" ,Equipo ="
                        +res.getString("equipo");
                System.out.println(impresion);
            }


        }catch (SQLException e){
            System.out.println("Consulta KO");
            throw new RuntimeException(e);

        }finally {
            if(s!=null)s.close();
            if(c!=null)c.close();
        }
    }
    // Método para consulta de jugadores con otra query
    public static void buscarJugadores2 () throws SQLException {

        Connection c = conectorDB();
        PreparedStatement s = null;

        try{
            s = c.prepareStatement(" SELECT nombre, COUNT(nombre) as suma FROM Jugadores GROUP BY nombre;");

            ResultSet res = s.executeQuery();

            while(res.next()){
                String impresion ="Nombre = "
                        +res.getString("nombre")
                        +" suma total = "
                        +res.getInt("suma");
                System.out.println(impresion);
            }


        }catch (SQLException e){
            System.out.println("Consulta KO");
            throw new RuntimeException(e);

        }finally {
            if(s!=null)s.close();
            if(c!=null)c.close();
        }
    }
}
