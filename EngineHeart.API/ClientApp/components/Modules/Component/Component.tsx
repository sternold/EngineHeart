import * as React from 'react';
import {Label, Table} from 'semantic-ui-react';
import {ComponentList} from "./ComponentList";
import {mRobotComponent} from "../../../models/mRobotComponent";
import {ComponentContainer} from "./ComponentContainer";

interface ComponentProps {
    component: mRobotComponent
}

export class Component extends React.Component<ComponentProps, {}> {
    static List = ComponentList;
    static Container = ComponentContainer;

    public render() {
        const {component} = this.props;
        return <Table.Row>
            <Table.Cell width={4}><h4>{component.component.name}</h4></Table.Cell>
            <Table.Cell width={1} textAlign='center'><Label circular size='huge'>{component.rating}</Label></Table.Cell>
        </Table.Row>
    }
}
