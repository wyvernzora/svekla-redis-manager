![](https://github.com/jluchiji/svekla-redis-manager/raw/master/HermaeusMora/Resources/%D0%A1%D0%B2%D0%B5%D0%BA%D0%BB%D0%B0.png)
Svekla Redis Manager
====================

A manager for Redis databases based on WinForms and ServiceStack.

This project is aimed at creating a convenient Redis management interface for .Net platform so that database admins won't have to rely on web/terminal based solutions. At this moment this project is intended for my personal use only since I do (and will do) a lot of Redis related programming where such a tool would come in handy.

The project was initially codenamed **"[Hermaeus Mora](http://elderscrolls.wikia.com/wiki/Hermaeus_Mora)"** after the *Daedric Prince of Knowledge and Memory* (see TES:Skyrim). The official name **Svekla** comes from Russian *[Свёкла](http://ru.wikipedia.org/wiki/%D0%A1%D0%B2%D1%91%D0%BA%D0%BB%D0%B0)*, which is a plant resembling radish.

# Design Goals #

- A nice and intuitive UI
- Smart caching and background sync with database
- Performance, of course

# Current Progress #

At this moment manager can connect to Redis databases and detect different types of request timeouts. It also supports password authenticated Redis servers and detects if the password is corrent, though at present the program allows unlimited number of tries. Need to add some kind of security mechanism to limit number/frequency of wrong password tries.

When connecting to a server for the first time, the program may require some time to pull key list and associated info. Well.. it may not even be "brief".. though I made a nice loading animation so it won't be boring. All the loaded data is cached locally so that after the first time it won't be necessary to pull data again. In the current version of the program local cache **is not maintained** so changes on the server side are not reflected locally unless going through the pull-data process again. I think that I will come up with a mechanism that will update information in the background without blocking any user operations.

It is planned to support pretty much all Redis server commands, though no concrete plans have been established.

# Cloning This Repository #

Due to certain limitations of the original ServiceStack.Redis project, Svekla uses a custom fork of the ServiceStack.Redis that can be found [here](https://github.com/jluchiji/ServiceStack.Redis). If you clone Svekla Redis Manager repository, please clone my ServiceStack.Redis fork as well. Then, if ServiceStack.Redis project shows broken, remove it and add the fork you cloned to the Svekla solution.


# Attributions #

## ServiceStack.Redis ##
Parts of this software are based on [ServiceStack](http://www.servicestack.net/) project.

## ObjectListView ##
Parts of this software are based on [ObjectListView](http://objectlistview.sourceforge.net/cs/index.html) project.

## MdiClientController ##
Advanced MDI client area tweaking was achieved via [MdiClientController component by Jacob Slusser](http://www.codeproject.com/Articles/8489/Getting-a-quot-Handle-quot-on-the-MDI-Client).

## Ripple Demo ##
Demo in the About dialog is made by me. For more details about water physics simulation see [my blog post](http://www.wyvernzora.com/2012/12/ripple-effect-in-winforms-c.html).

## Artwork ##
All icons used within the software are made by me. Illustration on the connection screen by [たかりゃん](http://www.pixiv.net/member.php?id=865499). Illustrations used in loading indicator are by [はりぼて](http://www.pixiv.net/member.php?id=3145937).