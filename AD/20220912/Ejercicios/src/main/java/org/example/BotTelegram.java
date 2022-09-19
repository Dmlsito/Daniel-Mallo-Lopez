package org.example;
import java.util.Scanner;

import org.omg.Messaging.SyncScopeHelper;
import org.telegram.telegrambots.bots.TelegramLongPollingBot;
import org.telegram.telegrambots.meta.api.methods.send.SendMessage;
import org.telegram.telegrambots.meta.api.objects.Update;
import org.telegram.telegrambots.meta.exceptions.TelegramApiException;



public class BotTelegram extends TelegramLongPollingBot {

    public void main(String[] args) {

        Scanner teclado = new Scanner(System.in);
        final Update update = null;
        String texto = "";
        String chatId = "";

        // Al recibir el texto /start el bot le dara la bienvenida al usuario, incluyendo al final del texto "Pulse /ayuda si desea mas informacion"

        if (texto.equals("/start")) {
            onUpdateReceived(update);
            System.out.println("dadad");
        }
        // Al recibir el texto /ayuda el bot mostrara los comandos disponibles .


        // Al recibir el texto /hola el bot devolvera el dia y la hora actual.
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
        message.setText("Bienvenido, pulse /help si desea mas informacion");
        message.setChatId(String.valueOf(chatId));

        return message;

    }





}
