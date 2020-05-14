using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillRow
{
    public int id { get; set; }

    public string loc_skill_name { get; set; }

    // 技能类型: 1.位移 2.跳跃 3.JETPACK
    public int skill_type { get; set; }

    // 可触发状态，将所有可触发状态对应数值相加填入         IDLE = 1,         MOVE = 2,         JUMP = 4,         FALL = 8 ,         DIE = 16,         RESPAWN = 32,         SKILL = 64,         CANT_CONTROL = 128,
    public int state_mask { get; set; }

    // 准备时间，一般用于播放起始动画
    public float prepare_time { get; set; }

    public float duration { get; set; }

    // 结束时间，用于播放收尾动画
    public float end_time { get; set; }

    // 是否接受玩家方向输入控制
    public bool accept_move_control { get; set; }

    // 是否沿着当前移动方向移动，设1则沿当前移动方向以move_speed移动，设0则沿角色朝向以move_speed移动
    public bool follow_move_dir { get; set; }

    // 移动方向及速度，单位坐标系
    public UnityEngine.Vector3 move_speed { get; set; }

    // 默认为0，填1则不受重力影响
    public bool disable_gravity { get; set; }

    public float jump_height { get; set; }

    // 投射物id
    public int projectile_id { get; set; }

    // 投射物发射方向，单位坐标系
    public UnityEngine.Vector3 projectile_dir { get; set; }

    // 可变参数
    public float skill_param_1 { get; set; }

    // 可变参数
    public float skill_param_2 { get; set; }

    // 可变参数
    public float skill_param_3 { get; set; }
}
