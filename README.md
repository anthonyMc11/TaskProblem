Problem

https://stackoverflow.com/questions/78848402/task-delay-is-10x-slower-in-docker-linux-than-in-windows

I am struggling with a timing issue I have in Docker

What I want is for the system to wait around 1ms.

However I am getting these results:

Linux (ubuntu on WSL using docker) | Timer is accurate within 1 nanoseconds:
await Task.Delay(1).ConfigureAwait(false) is roughly 10 ms (my bad case)
Thread.Sleep() is 1.0712ms (really good)

in contrast, I get the follow result on Windows and directly on Ubuntu.

Windows | Timer is accurate within 100 nanoseconds:
await Task.Delay(1)   is roughly 1.942 ms (acceptable)
Thread.Sleep(1)       is again roughly 1.942ms (acceptable)

Linux (ubuntu running the exe):
await Task.Delay(1)   is roughly 1.942 ms (acceptable)
Thread.Sleep(1)       is again roughly 1.942ms (acceptable)

I need to use docker and Task.Delay() as to not block the thread however with the performance being 10x what is should b, it's not really an option.

My question is how to fix Task.Delay() under Docker linux to not be so slow.
