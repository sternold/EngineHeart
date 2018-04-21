import {mRobotComponent} from "./mRobotComponent";

export class mRobot {
    id: number;
    name: string;
    player: string; 
    originalPurpose: string;
    realityCom: number;
    humanCom: number;
    digiCon: number;
    mechaniCon: number;
    dexterity: number;
    mobility: number;
    perception: number;
    reflexes: number;
    strength: number;
    durability: number;
    buffer: number;
    size: number;
    power: number;
    interactionPool: number;
    tnToBeStruck: number;
    damageFromStrike: number;
    initiative: number;
    speed: number;
    osThreshold: number;
    damageThreshold: number;
    components: mRobotComponent[];
}
