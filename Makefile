target = sample
objs = main.o ../glad/glad.o
flags = -I ../include
OS := $(shell uname)

ifeq ($(OS), Darwin)
libs = -lglfw -framework OpenGL
else ifeq ($(OS), Linux)
libs = -ldl -lglfw -lGL -lGLU
endif

$(target): $(objs)
	g++ $(objs) -o sample  $(flags) $(libs)

.PHONY: clean dev run

run:
	./$(target)

clean:
	-rm -f $(target) $(objs)

dev: clean $(target) run
