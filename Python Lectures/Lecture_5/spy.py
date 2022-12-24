from telegram import Update
from telegram.ext import Updater, CommandHandler, CallbackContext

def log(update: Update, context: CallbackContext):
    file = open('Alex70_first/Python Lectures/Lecture_5/db.csv', 'a', encoding='utf-8')
    file.write(f'{update.effective_user.first_name},{update.effective_user.id}, {update.message.text}\n')
    file.close()