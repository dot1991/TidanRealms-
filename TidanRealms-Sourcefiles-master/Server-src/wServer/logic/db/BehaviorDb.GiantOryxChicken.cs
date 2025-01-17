﻿using wServer.logic.loot;
using wServer.logic.transitions;
using wServer.logic.behaviors;
using common.resources;
//by Classic White
namespace wServer.logic
{
    partial class BehaviorDb
    {
        private _ GiantOryxChicken = () => Behav()
            .Init("Test Egg",
                new State(
                    new State("Idle",
                        new HpLessTransition(0.8, "1")
                    ),
                    new State("1",
                        new HpLessTransition(0.6, "2"),
                        new SetAltTexture(1)
                    ),
                    new State("2",
                        new HpLessTransition(0.4, "3"),
                        new SetAltTexture(2)
                    ),
                    new State("3",
                        new HpLessTransition(0.2, "4"),
                        new SetAltTexture(3)
                    ),
                    new State("4",
                        new ConditionalEffect(ConditionEffectIndex.Invincible),
                        new SetAltTexture(4),
                        new TimedTransition(250, "Break")
                    ),
                    new State("Break",
                        new Transform("TestChicken 2")
                    )
                )
            )
            .Init("TestChicken 2",
                new State(
                    new DropPortalOnDeath("Locked Wine Cellar Portal", 1, 60),
                    new State("Idle",
             new ChangeSize(20, 100),
                        new TimedTransition(600, "Phase One")
                    ),
                    new State("Phase One",
                        new Taunt("CLUCK!"),
                        new State("Shoot",
                            new Shoot(15, projectileIndex: 0, count: 4, fixedAngle: 90, angleOffset: 0, coolDown: 4000, coolDownOffset: 200),
                            new Shoot(15, projectileIndex: 0, count: 4, fixedAngle: 90, angleOffset: 20, coolDown: 4000, coolDownOffset: 400),
                            new Shoot(15, projectileIndex: 0, count: 4, fixedAngle: 90, angleOffset: 40, coolDown: 4000, coolDownOffset: 600),
                            new Shoot(15, projectileIndex: 0, count: 4, fixedAngle: 90, angleOffset: 60, coolDown: 4000, coolDownOffset: 800),
                            new Shoot(15, projectileIndex: 0, count: 4, fixedAngle: 90, angleOffset: 80, coolDown: 4000, coolDownOffset: 1000),
                            new Shoot(15, projectileIndex: 0, count: 4, fixedAngle: 90, angleOffset: 100, coolDown: 4000, coolDownOffset: 1200),
                            new Shoot(15, projectileIndex: 0, count: 4, fixedAngle: 90, angleOffset: 120, coolDown: 4000, coolDownOffset: 1400),
                            new Shoot(15, projectileIndex: 0, count: 4, fixedAngle: 90, angleOffset: 140, coolDown: 4000, coolDownOffset: 1600),
                            new Shoot(15, projectileIndex: 0, count: 4, fixedAngle: 90, angleOffset: 160, coolDown: 4000, coolDownOffset: 1800),
                            new Shoot(15, projectileIndex: 0, count: 4, fixedAngle: 90, angleOffset: 180, coolDown: 4000, coolDownOffset: 2000),
                            new Shoot(15, projectileIndex: 0, count: 4, fixedAngle: 90, angleOffset: 200, coolDown: 4000, coolDownOffset: 2200),
                            new Shoot(15, projectileIndex: 0, count: 4, fixedAngle: 90, angleOffset: 220, coolDown: 4000, coolDownOffset: 2400),
                            new Shoot(15, projectileIndex: 0, count: 4, fixedAngle: 90, angleOffset: 240, coolDown: 4000, coolDownOffset: 2600),
                            new Shoot(15, projectileIndex: 0, count: 4, fixedAngle: 90, angleOffset: 260, coolDown: 4000, coolDownOffset: 2800),
                            new Shoot(15, projectileIndex: 0, count: 4, fixedAngle: 90, angleOffset: 280, coolDown: 4000, coolDownOffset: 3000),
                            new Shoot(15, projectileIndex: 0, count: 4, fixedAngle: 90, angleOffset: 300, coolDown: 4000, coolDownOffset: 3200),
                            new Shoot(15, projectileIndex: 0, count: 4, fixedAngle: 90, angleOffset: 320, coolDown: 4000, coolDownOffset: 3400),
                            new Shoot(15, projectileIndex: 0, count: 4, fixedAngle: 90, angleOffset: 340, coolDown: 4000, coolDownOffset: 3600),
                            new Shoot(15, projectileIndex: 0, count: 4, fixedAngle: 90, angleOffset: 360, coolDown: 4000, coolDownOffset: 3800),
                            new Shoot(15, projectileIndex: 4, count: 3, shootAngle: 20, coolDown: 1000),
                            new StayCloseToSpawn(0.6, 5),
                            new Wander(0.5),
                            new HpLessTransition(.800, "Phase Two")
                        ),
                        new State("Phase Two",
                            new RemoveConditionalEffect(ConditionEffectIndex.Invulnerable),
                            new Taunt("Cluck cluck cluck ... CLUCK!"),
                            new Shoot(0, count: 5, projectileIndex: 0, coolDown: 250, fixedAngle: 0, rotateAngle: 15, shootAngle: 15),
                            new Shoot(0, count: 5, projectileIndex: 0, coolDown: 250, fixedAngle: 180, rotateAngle: 15, shootAngle: 15),
                            new HpLessTransition(.600, "Static1")
                        ),
                        new State("Static1",
                            new ConditionalEffect(ConditionEffectIndex.Invulnerable, true),
                            new TimedTransition(3000, "Phase Three")
                        ),
                        new State("Phase Three",
                            new ConditionalEffect(ConditionEffectIndex.Invulnerable, true),
                            new Wander(0.2),
                            new Follow(0.4, 6, 1),
                            new Shoot(22, count: 5, projectileIndex: 8, shootAngle: 20, fixedAngle: 180, coolDown: 500),
                            new Shoot(22, count: 5, projectileIndex: 7, shootAngle: 20, fixedAngle: 180, coolDown: 500),
                            new Shoot(22, count: 5, projectileIndex: 8, shootAngle: 20, fixedAngle: 360, coolDown: 500),
                            new Shoot(22, count: 5, projectileIndex: 7, shootAngle: 20, fixedAngle: 360, coolDown: 500),
                            new TimedTransition(500, "Immune"),
                            new HpLessTransition(0.3, "AlotOfBullets")
                        ),
                        new State("Immune",
                            new ConditionalEffect(ConditionEffectIndex.Invulnerable, true),
                            new Wander(0.2),
                            new Follow(0.4, 6, 1),
                            new TimedTransition(500, "Phase Three2"),
                            new HpLessTransition(0.3, "AlotOfBullets")
                        ),
                        new State("Phase Three2",
                            new ConditionalEffect(ConditionEffectIndex.Invulnerable, true),
                            new Wander(0.2),
                            new Follow(0.4, 6, 1),
                            new Shoot(22, count: 5, projectileIndex: 8, shootAngle: 20, fixedAngle: 90, coolDown: 500),
                            new Shoot(22, count: 5, projectileIndex: 7, shootAngle: 20, fixedAngle: 90, coolDown: 500),
                            new Shoot(22, count: 5, projectileIndex: 8, shootAngle: 20, fixedAngle: 270, coolDown: 500),
                            new Shoot(22, count: 5, projectileIndex: 7, shootAngle: 20, fixedAngle: 270, coolDown: 500),
                            new TimedTransition(500, "Damageable"),
                            new HpLessTransition(0.3, "AlotOfBullets")
                        ),
                        new State("Damageable",
                            new RemoveConditionalEffect(ConditionEffectIndex.Invulnerable),
                            new Wander(0.2),
                            new Follow(0.4, 6, 1),
                            new TimedTransition(500, "Phase Three"),
                            new HpLessTransition(0.3, "AlotOfBullets")
                        ),
                            new State("AlotOfBullets",
                                new ConditionalEffect(ConditionEffectIndex.Invulnerable, true),
                                new Wander(0.1),
                                new StayCloseToSpawn(0.1, 1),
                                new Shoot(20, count: 5, projectileIndex: 2, shootAngle: 25, fixedAngle: 90, coolDown: 1000),
                                new Shoot(20, count: 5, projectileIndex: 2, shootAngle: 25, fixedAngle: 270, coolDown: 1000),
                                new Shoot(20, count: 10, projectileIndex: 3, shootAngle: 10, fixedAngle: 180, coolDown: 1000),
                                new Shoot(20, count: 10, projectileIndex: 3, shootAngle: 10, fixedAngle: 360, coolDown: 1000),
                                new TimedTransition(1000, "Static2"),
                                new HpLessTransition(0.120, "FinalPhase")
                                ),
                            new State("Static2",
                                new ConditionalEffect(ConditionEffectIndex.Invulnerable, true),
                                new Wander(0.1),
                                new StayCloseToSpawn(0.1, 1),
                                new TimedTransition(1000, "AttackingAgain"),
                                new HpLessTransition(0.120, "FinalPhase")
                                ),
                            new State("AttackingAgain",
                                new RemoveConditionalEffect(ConditionEffectIndex.Invulnerable),
                                new Wander(0.1),
                                new StayCloseToSpawn(0.1, 1),
                                new Shoot(20, count: 5, projectileIndex: 2, shootAngle: 25, fixedAngle: 90, coolDown: 1000),
                                new Shoot(20, count: 5, projectileIndex: 2, shootAngle: 25, fixedAngle: 270, coolDown: 1000),
                                new Shoot(20, count: 10, projectileIndex: 3, shootAngle: 10, fixedAngle: 180, coolDown: 1000),
                                new Shoot(20, count: 10, projectileIndex: 3, shootAngle: 10, fixedAngle: 360, coolDown: 1000),
                                new TimedTransition(1000, "Static3"),
                                new HpLessTransition(0.120, "FinalPhase")
                                ),
                            new State("Static3",
                                new ConditionalEffect(ConditionEffectIndex.Invulnerable, true),
                                new Wander(0.1),
                                new StayCloseToSpawn(0.1, 1),
                                new TimedTransition(1000, "AlotOfBullets"),
                                new HpLessTransition(0.120, "FinalPhase")
                                ),
                    new State("FinalPhase",
                        new ConditionalEffect(ConditionEffectIndex.Invulnerable, true),
                        new Wander(0.5),
                        new Follow(0.5, 6, 1),
                        new Shoot(10, count: 5, projectileIndex: 4, shootAngle: 20, predictive: 0.4, coolDown: 1000),
                        new Shoot(10, count: 10, projectileIndex: 3, shootAngle: 10, predictive: 1, coolDown: 2000),
                        new TimedTransition(4000, "FinalPhase2"),
                        new HpLessTransition(0.020, "CloseToDeath")
                        ),
                    new State("FinalPhase2",
                        new RemoveConditionalEffect(ConditionEffectIndex.Invulnerable),
                        new Wander(0.4),
                        new Follow(0.4, 6, 1),
                        new Shoot(10, count: 5, projectileIndex: 4, shootAngle: 20, predictive: 0.4, coolDown: 1000),
                        new Shoot(10, count: 10, projectileIndex: 3, shootAngle: 10, predictive: 1, coolDown: 1500),
                        new TimedTransition(3000, "FinalPhase"),
                        new HpLessTransition(0.020, "CloseToDeath")
                        ),
                    new State("CloseToDeath",
                        new ConditionalEffect(ConditionEffectIndex.Invulnerable, true),
                        new Flash(0xffffff, 2, 1),
                        new TimedTransition(3000, "Death")
                        ),
                    new State("Death",
                        new Shoot(100, 10, projectileIndex: 6),
                        new Decay(100)
                        )
                        )
                ),
                new Threshold(0.05,
                    new TierLoot(9, ItemType.Weapon, 0.125),
                    new TierLoot(9, ItemType.Armor, 0.25),
                    new TierLoot(4, ItemType.Ability, 0.125),
                    new TierLoot(4, ItemType.Ring, 0.125),
                    new TierLoot(10, ItemType.Weapon, 0.0625),
                    new TierLoot(11, ItemType.Weapon, 0.0625),
                    new TierLoot(10, ItemType.Armor, 0.125),
                    new TierLoot(11, ItemType.Armor, 0.125),
                    new TierLoot(12, ItemType.Armor, 0.0625),
                    new TierLoot(5, ItemType.Ring, 0.0625),
                    new TierLoot(5, ItemType.Ability, 0.0625),
                    new ItemLoot("Potion of Attack", 0.3, 3),
                    new ItemLoot("Potion of Defense", 0.3, 3),
                    new ItemLoot("Fragment of the Earth", 0.01),
                    new ItemLoot("Chicken Leg of Doom", 0.006, damagebased: true),
                    new ItemLoot("Anatis Staff", 0.006, damagebased: true),
                    new ItemLoot("Apocalypse Feather", 0.006, damagebased: true)
                    )
            );
    }
}