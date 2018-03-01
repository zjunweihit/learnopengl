target = sample
objs = main.cpp ../glad/glad.c
flags = -I ../include
OS := $(shell uname)

ifeq ($(OS), Darwin)
libs = -lglfw -framework OpenGL
else ifeq ($(OS), Linux)
libs = -ldl -lglfw -lGL -lGLU
endif

$(target): $(objs)
	g++ $^ -o $@ $(libs) $(flags)

.PHONY: clean dev run

run:
	./$(target)

clean:
	-rm -f $(target)

dev: clean $(target) run
