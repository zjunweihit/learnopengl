#version 330 core
out vec4 FragColor;
in vec3 ourColor;
uniform float greenValue;
void main()
{
	//FragColor = vec4(ourColor, 1.0f);
	FragColor = vec4(0.0f, greenValue, 0.0f, 1.0f);
}