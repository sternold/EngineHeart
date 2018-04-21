import * as React from 'react';
import { Statistic} from 'semantic-ui-react';
import {AttributeGroup} from "./AttributeGroup";
import {AttributeContainer} from "./AttributeContainer";

interface AttributeProps {
    prefix?: string,
    value: number,
    name: string,
    threshold?: boolean
}

export class Attribute extends React.Component<AttributeProps, {}> {
    static Container = AttributeContainer;
    static Group = AttributeGroup;
    
    public render() {
        const {prefix, value, name, threshold} = this.props;
        return <Statistic horizontal>
            { prefix ? <Statistic.Label>{prefix}</Statistic.Label> : false }
            { threshold ? <Statistic horizontal><Statistic.Value>0</Statistic.Value><Statistic.Label>/</Statistic.Label></Statistic> : false }
            <Statistic.Value>{value}</Statistic.Value>
            <Statistic.Label>{name}</Statistic.Label>
        </Statistic>;
    }
}
