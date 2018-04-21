import * as React from 'react';
import {RouteComponentProps} from 'react-router';
import {Card, Container, List, Statistic} from 'semantic-ui-react';

export class Home extends React.Component<RouteComponentProps<{}>, {}> {
    public render() {
        return <Container>
            <Card.Group itemsPerRow='3'>
                <Card>
                    <Card.Content textAlign='center'>
                        <Card.Header>Intelligence</Card.Header>
                        <List>
                            <List.Item>
                                <Statistic horizontal>
                                    <Statistic.Value>5</Statistic.Value>
                                    <Statistic.Label>RealityCom</Statistic.Label>
                                </Statistic>
                            </List.Item>
                            <List.Item>
                                <Statistic horizontal>
                                    <Statistic.Value>5</Statistic.Value>
                                    <Statistic.Label>HumanCom</Statistic.Label>
                                </Statistic>
                            </List.Item>
                            <List.Item>
                                <Statistic horizontal>
                                    <Statistic.Value>5</Statistic.Value>
                                    <Statistic.Label>DigiCon</Statistic.Label>
                                </Statistic>
                            </List.Item>
                            <List.Item>
                                <Statistic horizontal>
                                    <Statistic.Value>5</Statistic.Value>
                                    <Statistic.Label>MechaniCon</Statistic.Label>
                                </Statistic>
                            </List.Item>
                        </List>
                    </Card.Content>
                </Card>
            </Card.Group>
        </Container>;
    }
}
