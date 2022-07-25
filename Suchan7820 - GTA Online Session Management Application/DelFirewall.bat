@echo off
mode con cols=15 lines=1
netsh advfirewall firewall delete rule name="[Suchan7820]GTA Online Session Firewall TCP" dir=out
netsh advfirewall firewall delete rule name="[Suchan7820]GTA Online Session Firewall UDP" dir=out