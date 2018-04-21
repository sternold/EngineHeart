import * as React from 'react';
import {RouteComponentProps} from 'react-router';
import {Container, Loader, Segment} from 'semantic-ui-react';
import {Attribute} from './Modules/Attribute/Attribute';
import {mRobot} from '../models/mRobot';
import {Component} from "./Modules/Component/Component";
import {mRobotComponent} from "../models/mRobotComponent";
import {mComponent} from "../models/mComponent";

interface RobotParams {
    id: number
}

interface RobotState {
    ready: boolean,
    robot: mRobot
}

export class Robot extends React.Component<RouteComponentProps<RobotParams>, RobotState> {

    constructor(props: any) {
        super(props);
        this.state = {
            ready: false,
            robot: new mRobot()
        }
    }

    componentDidMount() {
        this.fetchRobot();
    }

    fetchRobot() {
        let {id} = this.props.match.params;
        fetch(`/api/robots/${id}`)
            .then((result) => {
                return result.json();
            })
            .then((robot) => {
                this.setState({robot: robot, ready: true});
            });
    }

    public render() {
        const {ready, robot} = this.state;
        return ready ? <Container>
            <Segment>
                Name:

                Player:

                Original Purpose:
            </Segment>
            <Attribute.Container>
                <Attribute.Group header={"Intelligence"}>
                    <Attribute value={robot.realityCom} name={"RealityCom"}/>
                    <Attribute value={robot.humanCom} name={"HumanCom"}/>
                    <Attribute value={robot.digiCon} name={"DigiCon"}/>
                    <Attribute value={robot.mechaniCon} name={"MechaniCon"}/>
                </Attribute.Group>
                <Attribute.Group header={"Chassis"}>
                    <Attribute value={robot.dexterity} name={"Dexterity"}/>
                    <Attribute value={robot.mobility} name={"Mobility"}/>
                    <Attribute value={robot.perception} name={"Perception"}/>
                    <Attribute value={robot.reflexes} name={"Reflexes"}/>
                    <Attribute value={robot.strength} name={"Strength"}/>
                </Attribute.Group>
                <Attribute.Group header={"Crux"}>
                    <Attribute value={robot.durability} name={"Durability"}/>
                    <Attribute value={robot.buffer} name={"Buffer"}/>
                    <Attribute value={robot.size} name={"Size"}/>
                    <Attribute value={robot.power} name={"Power"}/>
                </Attribute.Group>
                <Attribute.Group header={"Physical Interactions"}>
                    <Attribute value={robot.interactionPool} name={"Interaction Pool"}/>
                    <Attribute value={robot.tnToBeStruck} name={"TN to be Struck"}/>
                    <Attribute value={robot.damageFromStrike} name={"Damage from Strike"}/>
                </Attribute.Group>
                <Attribute.Group header={"Movement"}>
                    <Attribute value={robot.initiative} name={"Initiative"} prefix={"1d10 + "}/>
                    <Attribute value={robot.speed} name={"Speed"}/>
                </Attribute.Group>
                <Attribute.Group header={"Thresholds"}>
                    <Attribute value={robot.osThreshold} name={"OS Threshold"} threshold/>
                    <Attribute value={robot.damageThreshold} name={"Damage Threshold"} threshold/>
                </Attribute.Group>
            </Attribute.Container>
            <br/>
            <Component.Container>
                <Component.List header={"Features"}>
                    {robot.components.filter((component: mRobotComponent) => {
                        return component.component.type == mComponent.FEATURE;
                    }).map((component: mRobotComponent) => {
                        return <Component component={component}/>
                    })}
                </Component.List>
                <Component.List header={"Defects"}>
                    {robot.components.filter((component: mRobotComponent) => {
                        return component.component.type == mComponent.DEFECT;
                    }).map((component: mRobotComponent) => {
                        return <Component component={component}/>
                    })}
                </Component.List>
            </Component.Container>
        </Container> : <Loader active={true}><h5>Loading...</h5></Loader>;
    }
}
