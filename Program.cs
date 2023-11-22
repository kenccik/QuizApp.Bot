// See https://aka.ms/new-console-template for more information
using QuizApp.Bot.Models;
using System.Reflection.Metadata.Ecma335;
using Telegram.Bot;
using Telegram.Bot.Types;

Console.WriteLine("Hello, World!");
QuestionModel question = new QuestionModel() ;
int questionIndex = 0;
string step = "";
int questionNumber = 1;
string botToken = "6782200702:AAGdPysOwLW9oqTebh83KbeLkyM-Fq2cR4s";
TelegramBotClient bot = new TelegramBotClient(botToken);

bot.StartReceiving(
    updateHandler: (client, update, token) => GetUpdate(update),
    pollingErrorHandler: (client, exception, token) => Task.CompletedTask);
Console.ReadKey();

async Task GetUpdate(Update update)
{
    long chatId = update.Message!.Chat.Id;

    if (chatId != 639714232)
    {
        return;
    }

    string? message = update.Message.Text;

    if (message == "/start")
    {
        await bot.SendTextMessageAsync(chatId, @"
Menu

1.Profile
2.Test
3.Questions
4.Statistics
5.Add Test\n\n

Choose menu!");

        step = "menu";
        return;
    }

    if (message == "1")
    {
        User? user = update.Message.From;

        if (user == null)
        {
            return;
        }

        await bot.SendTextMessageAsync(chatId, @$"
Your Profile

Id: {user.Id}
Firtname: {user.FirstName ?? "NONE"}
LastName: {user.LastName ?? "NONE"}
UserName: @{user.Username ?? "NONE"}
IsBot: {user.IsBot}
");
        step = "profile";
    }

    if(message == "3")
    {
        step = "question";
        question = Data.Questions[0];

            await bot.SendTextMessageAsync(chatId, @$"
{questionNumber++}. {question.Question}
A. {question.AnswerA}
B. {question.AnswerB}
C. {question.AnswerC}
");
        return;

    }

    if (step == "question")
    {
            question = Data.Questions[++questionIndex];
            
            questionNumber = 1;

            await bot.SendTextMessageAsync(chatId, @$"
{questionNumber++}. {question.Question}
A. {question.AnswerA}
B. {question.AnswerB}
C. {question.AnswerC}
");
    }
}