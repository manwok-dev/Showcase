shader_type canvas_item;

uniform vec2 player_pos;
uniform float max_distance = 20050.0;
uniform bool player_behind = false;

void fragment() {
    if (COLOR.a != 0.0) {

        if (!player_behind) {
            COLOR.a = 1.0; // fully visible, no circle
        }
		else{
			//float distance_to_player = distance(FRAGCOORD.xy, player_pos);
			//COLOR.a = clamp((distance_to_player - max_distance), 0.2, 1.0);
			COLOR.a = 0.2;
			
		}
    }
}
