target = sample
objs = main.o ../glad/glad.o
flags = -I ../include
OS := $(shell uname)

ifeq ($(OS), Darwin)
libs = -lglfw -framework OpenGL
endif

$(target): $(objs)
	g++ $(objs) -o sample  $(flags) $(libs)

run:
	./$(target)

.PHONY : clean
clean :
	-rm $(target) $(objs)

