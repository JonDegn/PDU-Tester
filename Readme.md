# GSM PDU Demonstration

This is a program written to demonstrate some interesting capabilities in PDU SMS messages. I made it for a community talk I gave at Saintcon 2019. See my [blog post](https://jondegn.com/posts/2019-09-24/interesting-at-commands) for more info.

This program uses the [GSMComm library](http://www.scampers.org/steve/sms/libraries.htm).

## Usage

Connect a GSM module to your computer and start the program. Select the port the GSM module is connected in the port dropdown. If a port isn't in the list, click on the 'port' label to refresh the list.

There are only options for customizing the PID, DCS, and SRR since that was what I was showing in my presentation. This can easily be changed to modify whatever field you want.

In the Other tab, you send send arbitrary commands and see the log. (This isn't really tested, and may cause issues. See Known Issues) The log is saved on exit.

## Known Issues

- Unsolicited messages from the GSM module can cause the program to hang. Until all remaining bytes are read from the serial connection, the program won't work.
- Very limited features
