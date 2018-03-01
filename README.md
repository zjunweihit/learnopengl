# learnopengl

## Hardware
* Mac
```
MacBook Pro（视网膜显示屏，13 英寸，2014 年中）	Intel Iris Graphics	OGL:4.1	OCL:1.2
```
## glfw3
* Mac
```
brew install glfw3
```
  - This will give you a context for the highest version of OpenGL greater than or equal to 3.2 that is supported by your OS and GPU.
  - [4.1 - How do I create an OpenGL 3.0+ context?](http://www.glfw.org/faq.html#41__how_do_i_create_an_opengl_30_context)
```
glfwWindowHint(GLFW_OPENGL_FORWARD_COMPAT, GL_TRUE);
```
* install glfw3
```
sudo apt-get install glfw3
```
## glad
* Download from http://glad.dav1d.de
  - Language: C/C++
  - API: gl version 4.1
  - Profile: core
## glm
* https://github.com/g-truc/glm
```
git clone https://github.com/g-truc/glm.git
```
## stb image
* Download stb_image.h from https://github.com/nothings/stb
