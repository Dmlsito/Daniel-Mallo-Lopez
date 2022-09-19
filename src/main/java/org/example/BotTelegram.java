package org.example;
import java.util.Scanner;
import org.telegram.telegrambots.bots.TelegramLongPollingBot;
import org.telegram.telegrambots.meta.TelegramBotsApi;
import org.telegram.telegrambots.meta.api.methods.send.SendMessage;
import org.telegram.telegrambots.meta.api.objects.Update;
import org.telegram.telegrambots.meta.exceptions.TelegramApiException;
import org.telegram.telegrambots.updatesreceivers.DefaultBotSession;


public class BotTelegram extends TelegramLongPollingBot {

    public void main(String[] args) {

        Scanner teclado = new Scanner(System.in);
        final Update update = null;
        String texto = "";
        String chatId = "";

        registrarBot();

        // Al recibir el texto /start el bot le dara la bienvenida al usuario, incluyendo al final del texto "Pulse /ayuda si desea mas informacion"

        if (update.getMessage().equals("/start")) {
            texto = "bienvenido, pulse ayuda si desea mas información";
            onUpdateReceived(update);
        }

        // Al recibir el texto /ayuda el bot mostrara los comandos disponibles .

        if(update.getMessage().equals("/ayuda")) {
            texto = "Los comandos disponibles son los siguientes: \n" +
                    "/newbot - create a new bot\n" +
                    "/mybots - edit your bots [beta]\n" +
                    "\n" +
                    "Edit Bots\n" +
                    "/setname - change a bot's name\n" +
                    "/setdescription - change bot description\n" +
                    "/setabouttext - change bot about info\n" +
                    "/setuserpic - change bot profile photo\n" +
                    "/setcommands - change the list of commands\n" +
                    "/deletebot - delete a bot\n" +
                    "\n" +
                    "Bot Settings\n" +
                    "/token - generate authorization token\n" +
                    "/revoke - revoke bot access token\n" +
                    "/setinline - toggle inline mode (https://core.telegram.org/bots/inline)\n" +
                    "/setinlinegeo - toggle inline location requests (https://core.telegram.org/bots/inline#location-based-results)\n" +
                    "/setinlinefeedback - change inline feedback (https://core.telegram.org/bots/inline#collecting-feedback) settings\n" +
                    "/setjoingroups - can your bot be added to groups?\n" +
                    "/setprivacy - toggle privacy mode (https://core.telegram.org/bots#privacy-mode) in groups\n" +
                    "\n" +
                    "Games\n" +
                    "/mygames - edit your games (https://core.telegram.org/bots/games) [beta]\n" +
                    "/newgame - create a new game (https://core.telegram.org/bots/games)\n" +
                    "/listgames - get a list of your games\n" +
                    "/editgame - edit a game\n" +
                    "/deletegame - delete an existing game";
        }
        // Al recibir el texto /hola el bot devolvera el dia y la hora actual.

        if(update.getMessage().equals("/hola")){
            texto = "Son las: " ;
        }
        //Al recibir el texto /miNombre el bot devolvers el nombre del usuario de Telegram que consulta
        // Al recibir el texto /ultimoMensaje el bot devolvera el ultimo mensaje que mando ese usuario




    }

    // Esta funcion se invocara cuando nuestro bot reciba un mensaje

    public void onUpdateReceived(final Update update) {
        //Con esto obtenemos el menasje escrito por el usuario
        final String messageTextReceived = update.getMessage().getText();

        // Se obtiene el id del chat del usuario
        final long chatId = update.getMessage().getChatId();

        // Se procesa el mensaje
        SendMessage message = procesarMensaje(String.valueOf(chatId), messageTextReceived);

        try {
            //Se envia el mensaje
            execute(message);
        } catch (TelegramApiException e) {
            e.printStackTrace();
        }
    }

    @Override
    public String getBotToken() {
        //Se devuelve el token que nos genero el token que nos genero el BotFather de nuestro bot
        return "5617913792:AAE3h1ILHjOb48q6sTmQGuCZa_8cs7gMIy4";
    }

    public String getBotUsername() {
        //Se devuelve el nombre que le dimos al BotFather cuando creamos nuestro bot
        return "AulaNosa_daniiii";
    }

    // Procesamos el mensaje y devolvemos respuesta
    private SendMessage procesarMensaje(String chatId, String texto) {

        SendMessage message = new SendMessage();
        //Acutalizamos este contenido, para darle la respuesta deseada al usuario
        message.setText(texto);
        message.setChatId(String.valueOf(chatId));

        return message;

    }

    public static void registrarBot(){

        //Registramos el bot

        try{
            TelegramBotsApi botsApi = new TelegramBotsApi(DefaultBotSession.class);
            botsApi.registerBot(new EchoBot());
        }
        catch(TelegramApiException e){
            e.printStackTrace();
        }
    }









}