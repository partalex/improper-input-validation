#!/bin/bash

if [ "$#" -ne 1 ]; then
     echo "Usage: $1 [IP address or hostname]"
     exit 1
fi

host=$1
param="ping $host"         
eval $param 

# ipconfig | findstr /R /C:"IPv4 Address"
# 192.168.1.103 && echo \"Hello, this is Command injection exploit attack\"
