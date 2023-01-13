import discord 
from discord.ext import commands
import random
from config import settings

intents = discord.Intents.default() 
intents.message_content = True
bot = commands.Bot(command_prefix = settings['prefix'], intents=intents) 

@bot.command() 
async def hello(ctx): 
    author = ctx.message.author 
    await ctx.send(f'Hello, {author.mention}!') 

@bot.command()
async def rand(ctx, *arg):
    await ctx.reply(random.randint(0, 100))


bot.run(settings['token'])

