shader_type canvas_item;

uniform vec2 player_pos;
uniform float fade_distance = 80.0;

void fragment() {

    vec4 col = COLOR;

    // distance from player to this wall pixel
    float d = distance(FRAGCOORD.xy, player_pos);

    // if player is close to/behind wall → fade it
    float fade = smoothstep(fade_distance, 0.0, d);

    col.a = mix(1.0, 0.2, fade);

    COLOR = col;
}