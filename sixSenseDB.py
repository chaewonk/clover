import sqlite3

conn_user = sqlite3.connect('sixSense.db')
curs_user = conn_user.cursor()

def addUser(name, id, email):
    curs_user.execute("insert into user values (?, ?, ?)", (name, id, email))
    conn_user.commit()
    conn_user.close()


