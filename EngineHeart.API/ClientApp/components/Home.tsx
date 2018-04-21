import * as React from 'react';
import {RouteComponentProps} from 'react-router';
import {Container, Header, Segment} from 'semantic-ui-react';

export class Home extends React.Component<RouteComponentProps<{}>, {}> {
    public render() {
        return <Container>
            <Segment basic padded attached='top' size='massive'>
                <Header dividing>Hello World!</Header>
            </Segment>
        </Container>;
    }
}
